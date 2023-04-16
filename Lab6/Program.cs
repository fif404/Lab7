// Скрипников Сергей 22-ИСП-2/1 вариант 17
Queue<Item> queue = new Queue<Item>();

queue.Enqueue(new Item("Ручка шариковая", 20));
queue.Enqueue(new Item("Дневник", 30));
queue.Enqueue(new Item("Карандаш", 4));
queue.Enqueue(new Item("Тетрадь", 15));
queue.Enqueue(new Item("Ручка гелевая", 20));

double price = queue.Where(item => item.Name == "Ручка шариковая").Sum(item => item.Cost);


Console.WriteLine("Общая стоимость товаров с наименованием \"Ручка шариковая\": {0}", price);
Console.WriteLine("Товары очереди:");

foreach (var item in queue)
{
    Console.WriteLine("{0}, стоимость: {1}", item.Name, item.Cost);
}


class Item
{
    public string Name { get; set; }
    public double Cost { get; set; }

    public Item(string name, double cost)
    {
        Name = name;
        Cost = cost;
    }
}
Console.ReadKey();