namespace Exercise_2
{
    public class Base
    {
        public void DoWork() { WorkField++; }
        public int WorkField;
        public int WorkProperty {
            get { return 0; }
        }
    }
}
