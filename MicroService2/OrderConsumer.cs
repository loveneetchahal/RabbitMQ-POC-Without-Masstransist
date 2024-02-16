using MassTransit;
using ViewModel;

namespace MicroService2
{
    public class OrderConsumer :
       IConsumer<Order>
    {
        public async Task Consume(ConsumeContext<Order> context)
        {
            var data = context.Message;
            // message received.
            // a fake delay
            var msg = context.Message;
            var delay = 1000;
            await Task.Delay(delay);
            await context.RespondAsync(new Order
            {
                ProductName = "nkg"
            });
        }
    }
}
