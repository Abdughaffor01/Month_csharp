namespace task3_MyList
{
    public class MyList<T>
    {
        List<T> list=new List<T>();
        public void Add(T m)=>list.Add(m);
        public void Remove(T m) => list.Remove(m);
        public int Count() => list.Count;
        public bool Contains(T m)=>list.Contains(m);
        public override string ToString()
        {
            string name="";
            for (int i = 0; i <list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    name += list[i];
                }
                else name += name += list[i] + ",";     
            }
            return name;
        }

    }
}
