namespace Exercise_2
{
    public class Derived : Base
    {
        public new void DoWork() { WorkField++; }
        public new int WorkField;
        public new int WorkProperty {
            get { return 0; }
        }
    }
}
