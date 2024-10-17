using AdapterPattern;
using System;

class Program
{
    static void Main(string[] args)
    {
        ComputerGame cyberpunk2077 = new ComputerGame(
            "Cyberpunk 2077",
            PegiAgeRating.P18,
            120,
            8192,
            70,
            16,
            6,
            3.5
        );

        PCGame adaptedGame = new ComputerGameAdapter(cyberpunk2077);

        Console.WriteLine("Название игры: " + adaptedGame.getTitle());

        Console.WriteLine("Минимальный возраст: " + adaptedGame.getPegiAllowedAge());

        Console.WriteLine("Является Triple-A: " + (adaptedGame.isTripleAGame() ? "Да" : "Нет"));

        Requirements reqs = adaptedGame.getRequirements();
        Console.WriteLine("Системные требования:");
        Console.WriteLine("  Видеопамять (ГБ): " + reqs.getGpuGb());
        Console.WriteLine("  Место на диске (ГБ): " + reqs.getHDDGb());
        Console.WriteLine("  Оперативная память (ГБ): " + reqs.getRAMGb());
        Console.WriteLine("  Частота процессора (ГГц): " + reqs.getCpuGhz());
        Console.WriteLine("  Количество ядер: " + reqs.getCoresNum());
    }
}
