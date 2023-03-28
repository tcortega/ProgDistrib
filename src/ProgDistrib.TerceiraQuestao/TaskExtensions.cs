namespace ProgDistrib.TerceiraQuestao;

public static class TaskExtensions
{
    // Um simples WhenAll mesclado com LINQ
    public static async Task<IEnumerable<T>> WaitAllWithResults<T>(this List<Task<T>> tasks)
    {
        await Task.WhenAll(tasks);
        return tasks.Select(x => x.Result);
    }
}