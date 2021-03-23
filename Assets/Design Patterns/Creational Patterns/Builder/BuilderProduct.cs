public interface IBuilderProduct {
    string Name { get; set; }
    int Points { get; set; }
    float Size { get; set; }
    string Material { get; set; }
    float Mass { get; set; }

    void ListDetails();
}

public class BuilderProduct : IBuilderProduct {
    public string Name { get; set;}
    public int Points { get; set; }
    public float Size { get; set; }
    public string Material { get; set; }
    public float Mass { get; set; }

    public void ListDetails () {
        GUIConsole.Instance.Log($"Product: {Name} \n\t Points: {Points} \n\t Size: {Size} \n\t Material: {Material} \n\t Mass: {Mass}");
    }
}
