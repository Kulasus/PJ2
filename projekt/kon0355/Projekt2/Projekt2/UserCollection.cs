using System;
using System.Collections;


namespace Projekt2
{
    /*Trida UserCollection slouzi jako kolekce pro User objekty. Ma dynamicke zvysovani a snizovani velikosti.
      Navic dokaze smazat jakykoliv prvek podle User.username na jakemkoliv indexu a prvky presunout tak aby 
      nezustal prazdny index. Dale umi naklonovat svuj obsah podle jine instance UserColleciton metodou Clone().
      Pozor! Metoda clone smaze veskery obsah kolekce do ktere se klonuje! Pro vkladani slouzi metoda Add(User). 
      Pro mazani prvku slouzi metoda Remove(String). Pro vraceni jednoho specifickeho prvku slouzi 
      metoda Get(String). Kolekce dale osetruje duplicitni username a tim tak trochu simuluje funkcionalitu 
      slovniku. Na konec funkce rozsiruje rozhrani IEnumerable aby se s ni dalo pracovat pres cyklus foreach. */
    class UserCollection : IEnumerable
    {
        private User[] array;
        public UserCollection()
        {
            array = new User[0];
        }
        public bool Add(User u)
        {
            if (Get(u.Username) == null)
            {
                IncreaseSize();
                array[array.Length - 1] = u;
                return true;
            }
            return false;
        }
        public User Get(string username)
        {
            foreach(User u in array)
            {
                if(u.Username == username)
                {
                    return u;
                }
            }
            return null;
        }
        public bool Remove(string username)
        {
            int index = 0;
            foreach(User u in array)
            {
                if(u.Username == username)
                    if(array.Length > 1)
                    {
                        MoveItemsBackFromIndex(index);
                        DecreaseSize();
                        return true;
                    }
                    else
                    {
                        DecreaseSize();
                        return true;
                    }
                index++;
            }
            return false;
        }
        public void Clone(UserCollection uc)
        {
            Erase();
            foreach(User u in uc)
            {
                Add(u);
            }
        }
        public void SortByUsernameAsc()
        {
            Array.Sort(array, delegate (User x, User y) { return x.Username.CompareTo(y.Username); });
        }
        public void SortByUsernameDesc()
        {
            Array.Sort(array, delegate (User x, User y) { return -(x.Username.CompareTo(y.Username)); });
        }
        public void Erase()
        {
            while(array.Length > 0)
            {
                DecreaseSize();
            }
        }
        private void MoveItemsBackFromIndex(int index)
        {
            for (int i = index; i < array.Length; i++)
            {
                array[index] = array[index + 1];
            }
        }
        private void IncreaseSize()
        {
            User[] biggerArray = new User[array.Length + 1];
            int copyIndex = 0;
            foreach (User u in array)
            {
                biggerArray[copyIndex] = array[copyIndex];
                copyIndex++;
            }
            array = biggerArray;
        }
        private void DecreaseSize()
        {
            User[] smallerArray = new User[array.Length - 1];
            int copyIndex = 0;
            while (copyIndex < array.Length - 1)
            {
                smallerArray[copyIndex] = array[copyIndex];
                copyIndex++;
            }
            array = smallerArray;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        private UserCollectionEnumerator GetEnumerator()
        {
            return new UserCollectionEnumerator(array);
        }
    }

    class UserCollectionEnumerator : IEnumerator
    {
        public User[] users;
        int position = -1;
        public UserCollectionEnumerator(User[] list)
        {
            users = list;
        }
        public User Current
        {
            get
            {
                try
                {
                    return users[position];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }
        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            position++;
            return (position < users.Length);
        }
        public void Reset()
        {
            position = -1;
        }
    }
}
