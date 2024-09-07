namespace _003_Linq.DataSource
{
    public class VeterinaryClinic
    {
        public int Id { get; set; }
        public string Name { get; }

        public VeterinaryClinic(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
