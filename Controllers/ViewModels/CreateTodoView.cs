using System.ComponentModel.DataAnnotations;

public class CreateTodoViewModel{
    [Required]
    public string Title { get; set;}
}