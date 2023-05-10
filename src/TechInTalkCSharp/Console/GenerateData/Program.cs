using Bogus;

namespace GenerateData
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var orderIds = 0;
            var testOrders = new Faker<Order>()
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
                .RuleFor(o => o.OrderId, f => orderIds++)
                .RuleFor(o => o.Quantity, f => f.Random.Number(1, 10));

            var users = testOrders.Generate(10);
            foreach (var user in users)
            {
                Console.WriteLine(user.FirstName + user.OrderId);
            }

        }
    }

    internal class Order
    {
        public string FirstName { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
    }
}