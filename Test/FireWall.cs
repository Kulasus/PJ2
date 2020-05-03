using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TestPJ2
{
    class FireWall
    {
        public List<Rule> Rules = new List<Rule>();
        private List<int> usage = new List<int>();
        public FireWall(String pathToFile)
        {
            String[] lines = File.ReadAllLines(pathToFile);
            for (int i = 0; i < lines.Length; i++)
            {
                String[] rules = lines[i].Split('-');
                foreach(String s in rules)
                {
                    s.Trim();
                }
                IPAddress newIP = new IPAddress(rules[0], rules[1]);
                Access newAc = rules[2] == " N" ? Access.Deny : Access.Allow;
                Rules.Add(new Rule(newIP, newAc));
                usage.Add(0);
            }
        }
        public bool Test(String ip)
        {
            Rule rule;
            int count = 0;
            foreach (Rule r in Rules)
            {
                if(r.Network.IsInNetwork(ip))
                {
                    rule = r;
                    usage[count] += 1;
                    return r.Type == Access.Allow ? true : false;
                }
                count++;
            }
            return false;
            throw new FirewallException(new IPAddress(ip, "0.0.0.0"));
        }

        public void Info()
        {
            int count = 0;
            foreach(Rule r in Rules)
            {
                Console.WriteLine(r.ToString() + " - usage: " + usage[count]);
                count++;
            }
        }

    }
}
