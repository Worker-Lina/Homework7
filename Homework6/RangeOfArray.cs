
namespace Homework7
{
    public class RangeOfArray
    {
        public int First { get; set; }
        public int Last { get; set; }
        private int length;


        private string[] userName;

        public RangeOfArray() { }
        public RangeOfArray(int length)
        {
            this.length = length;
            userName = new string[length];
        }

        public int GetLength()
        {
            return length;
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index == First)
                {
                    index = index - index;
                }
                else if (index < 0 && index > First)
                {
                    index = -(First - index);
                }
                else if (index >= 1 && First >= 1)
                {
                    index = index - First;
                }
                else if (index >= 0 && First < 0)
                {
                    index = index - First;
                }
                return userName[index];
            }
            set
            {
                if(index < 0 && index == First)
                {
                    index = index - index;
                }
                else if (index < 0 && index > First)
                {
                    index = -(First - index);
                }
                else if (index >= 1 && First >= 1)
                {
                    index = index - First;
                }
                else if(index >=0 && First < 0)
                {
                    index = index - First;
                }
                userName[index]=value;
            }
        }
    }
}
