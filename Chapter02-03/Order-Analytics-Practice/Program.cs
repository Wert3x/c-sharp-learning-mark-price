using System.Net.WebSockets;

var orders = new[]
{
    (Id: 101, Items: new[] { "Ноутбук", "Мышка", "Клавиатура" }, Total: 1250.00m, Status: "delivered"),
    (Id: 102, Items: new[] { "Телефон" }, Total: 899.99m, Status: "shipped"),
    (Id: 103, Items: new[] { "Наушники", "Чехол" }, Total: 150.50m, Status: "processing"),
    (Id: 104, Items: new string[] { }, Total: 0.00m, Status: "cancelled"),
    (Id: 105, Items: new[] { "Монитор", "Кабель", "Подставка", "Коврик" }, Total: 450.00m, Status: "new"),
    (Id: 106, Items: new[] { "Планшет", "Стилус" }, Total: 1200.00m, Status: "delivered"),
    (Id: 107, Items: new[] { "Книга" }, Total: 25.00m, Status: "delivered"),
};

foreach (var order in orders)
{
    System.Console.WriteLine($"\n=== Заказ #{order.Id} ===");

    //======СТАТУС======
    string status = order.Status switch
    {
        "new" => "Новый",
        "processing" => "В обработке",
        "shipped" => "Отправлен",
        "delivered" => "Доставлен",
        "cancelled" => "Отменен",
        _ => "Неизвестный статус",
    };
    System.Console.WriteLine($"Статус: {status}");

    //======ТОВАРЫ=======
    string items = string.Join(", ", order.Items);
    System.Console.WriteLine($"Товары: [{items}]");

    var orderSize = order.Items switch
    {
        [] => "Пустой заказ",
        [_] => $"Один товар: {order.Items[0]}",
        [var first, var second] => $"Два товара: {first}, {second}",
        [var first, .., var last] => $"Много товаров: первый: {first}, последний: {last}"
    };
    System.Console.WriteLine($"Размер: {orderSize}");

    //======СУММА======
    System.Console.WriteLine($"Сумма: {order.Total:C}");

    //======КАТЕГОРИЯ======
    string category = "";

    if (order.Total is 0)
    {
        category = "Пустой";
    }

    else if (order.Total is > 0 and < 100)
    {
        category = "Мелкий";
    }

    else if (order.Total is < 500)
    {
        category = "Средний";
    }

    else if (order.Total is < 1000)
    {
        category = "Крупный";
    }

    else if (order.Total is >= 1000)
    {
        category = "VIP";
    }
    System.Console.WriteLine($"Категория: {category}");

    //======КОММЕНТАРИЙ======
    System.Console.Write("Комментарий: ");
    switch(category)
    {
        case "Пустой":
            System.Console.WriteLine("Заказ пуст.");
            break;
        case "Мелкий":
            System.Console.WriteLine("Маленький заказ.");
            break;
        case "Средний":
            System.Console.WriteLine("Обычный заказ.");
            break;
        case "Крупный":
            System.Console.WriteLine("Хороший заказ.");
            break;
        case "VIP":
            System.Console.WriteLine("Отличный заказ!");
            break;
        default:
            System.Console.WriteLine("Нет информации.");
            break;
    };
} 