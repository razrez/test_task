namespace Shapes.Domain.Common
{
    public abstract class BaseShape
    {
        public string Name { get; }

        protected BaseShape(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
    }

}