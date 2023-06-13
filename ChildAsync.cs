using System;
using System.Threading;
using System.Threading.Tasks;

public class ChildAsync
{
    public async Task<int> RunTaskAAsync()
    {
        var result = await Task.Run(RunTaskB); // Task<int>化されるのでawaitできる
        //Console.WriteLine(result);
        return result + 1;
    }

    public int RunTaskB() // 同期メソッド
    {
        return 1 + 2 + 3;
    }
}
