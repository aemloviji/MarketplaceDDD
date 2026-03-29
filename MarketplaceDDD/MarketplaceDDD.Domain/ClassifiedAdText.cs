using MarketplaceDDD.Framework;

namespace MarketplaceDDD.Domain
{
    public class ClassifiedAdText : Value<ClassifiedAdText>
    {
        public string Value { get; }

        internal ClassifiedAdText(string text) => Value = text;

        public static ClassifiedAdText FromString(string text) => new ClassifiedAdText(text);

        public static implicit operator string(ClassifiedAdText text) => text.Value;
    }

    public class temp
    {
        public void A()
        {
            ClassifiedAdText classifiedAdText = ClassifiedAdText.FromString("text");


            var str = "";
            str += classifiedAdText;

            string aaa = classifiedAdText;
        }
    }
}