using System;
namespace SynsEntity
{
    public class Eyewear : Product
    {
        //Author: Jesper
        public string sex { get; protected set; }
        public string shape { get; protected set; }
        public string color { get; protected set; }
        public int length { get; protected set; }

        public Eyewear()
        {

        }

        public Eyewear(string manufactor, string modelName, double price, int categoryID, string sex, string shape, string color, int length)
        {
            this.manufactor = manufactor;
            this.modelName = modelName;
            this.price = price;
            this.categoryID = categoryID;
            this.sex = sex;
            this.shape = shape;
            this.color = color;
            this.length = length;
        }

        public Eyewear(string sex, string shape, string color, int length, string manufactor, string modelName, double price)
        {
            this.sex = sex;
            this.shape = shape;
            this.color = color;
            this.length = length;
            this.manufactor = manufactor;
            this.modelName = modelName;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{manufactor} {modelName} {sex} {shape} {color} {length} {price:C}";
        }
    }
}
