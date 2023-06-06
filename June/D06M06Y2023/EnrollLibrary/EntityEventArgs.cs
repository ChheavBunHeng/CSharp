namespace EnrollLibrary
{
    public class EntityEventArgs: EventArgs
    {
        public string? Id { get; set; } =null;
        public EntityTypes Entity { get; set; } = EntityTypes.None;
    }
}