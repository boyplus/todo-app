using Agoda.IoC.Core;
using Managesio.Core.Dtos;
using Managesio.Core.Entities;
using Managesio.Core.Rspositories;

namespace Managesio.Core.Services;

public interface ITodoService
{
    public List<Todo> GetAll();
    public Todo GetById(int id);
    public void Create(string title, string note);
    public void Delete(int id);
    public void Update(int id, UpdateTodoRequest todoRequest);
}

[RegisterPerRequest]
public class TodoService : ITodoService
{
    private readonly ITodoRepository _todoRepository;
    public TodoService(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public List<Todo> GetAll()
    {
        return _todoRepository.GetAll();
    }

    public Todo GetById(int id)
    {
        return _todoRepository.GetById(id);
    }

    public void Create(string title, string note)
    {
        _todoRepository.Create(title,note);
        Console.WriteLine("inside service");
    }

    public void Delete(int id)
    {
        _todoRepository.Delete(id);
    }

    public void Update(int id, UpdateTodoRequest todo)
    {
        _todoRepository.Update(id, todo);
    }
}