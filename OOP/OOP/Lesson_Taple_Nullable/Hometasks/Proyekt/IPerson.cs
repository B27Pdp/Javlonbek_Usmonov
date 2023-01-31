namespace OOP.Lesson_Taple_Nullable.Hometasks.Proyekt
{
    public interface IPerson<TId>
        where TId : struct
    {
        TId Id { get; set; }
        byte age { get; set; }
        string name { get; set; }
    }
}
