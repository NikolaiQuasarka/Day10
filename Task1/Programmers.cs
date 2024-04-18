using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Programmers
    {
        public delegate void ProgrammersDelegate(object sender, EventArgs e);
        public event ProgrammersDelegate? OnDelete;
        public event ProgrammersDelegate? OnChanging;

        public Collection<Programmer> list { get; } = new Collection<Programmer>();
        public void Add(Programmer newPr)
        {
            list.Add(newPr);
            OnChanging?.Invoke(this, EventArgs.Empty);
        }
        public void Delete(int index)
        {
            if(list.Count>index)
            list.RemoveAt(index);
            else throw new IndexOutOfRangeException("Индекс вышел за пределы");
            OnDelete?.Invoke(this, EventArgs.Empty);
        }
    }
}
