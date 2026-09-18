string name = "Phone";
decimal price = 599.99m;
int quantity = 15;
double discountPercent = 5.0;

decimal preDiscountCost = price * quantity;
decimal discountCost = preDiscountCost * (decimal)(discountPercent / 100.0);
decimal finishCost = preDiscountCost - discountCost;

System.Console.WriteLine($"Товар: {name}");
System.Console.WriteLine($"Стоимость за 1 штуку: ${price}");
System.Console.WriteLine($"Количество: {quantity}");
System.Console.WriteLine($"Скидка: {discountPercent}%");
System.Console.WriteLine($"Полная стоимость: ${preDiscountCost}");
System.Console.WriteLine($"Размер скидки: $ {discountCost:F2}");
System.Console.WriteLine($"Финальная стоимость: ${finishCost}");