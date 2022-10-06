namespace PersonTests
{
    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
<<<<<<< HEAD
    public class Person : IMeasurable, IResettable
=======
    public class Person : IDisplayable, IComparable<Person>
>>>>>>> 74bb72bb0f9fea897fc4f262a9a1648e352cbc0b
    {
        private int _size;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="name">Person's name, empty by default.</param>
        public Person(string name = "")
        {
            this.Name = name.Trim();
            _size = GetTheNameSize(name);
        }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public virtual string Name { get; set; }


        public int Size { get { return _size; } }

        /// <summary>
        /// Returns a string that represents the person.
        /// </summary>
        /// <returns>String that represents the person.</returns>
        public override string ToString()
        {
            return this.Name;
        }

<<<<<<< HEAD
        public void Reset()
        {
            Name = String.Empty;
        }

        private int GetTheNameSize(string name)
        {
            return name.Length;
=======
        public void Display()
        {
            MessageBox.Show(this.Name);
        }

        public int CompareTo(Person person)
        {

            if(person.Name == this.Name)
            {
                return 1;
            }
            else
            {
                return -1;
            }
>>>>>>> 74bb72bb0f9fea897fc4f262a9a1648e352cbc0b
        }
    }
}