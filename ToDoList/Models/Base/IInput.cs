namespace ToDoList.Models.Base
{
    public interface IInput<T>
    {
        T ConvertToBaseValue();
    }
}