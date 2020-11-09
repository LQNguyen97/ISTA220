
namespace Indexers
{
	struct Name
	{
        private string name;

		public Name(string text)
		{
			name = text;
		}

		public string Text
		{
			get { return name; }
		}

		public override int GetHashCode() => name.GetHashCode();

		public override bool Equals(object other) => (other is Name) && Equals((Name)other);

		public bool Equals(Name other)
		{
			return name == other.name;
		}
	}
}