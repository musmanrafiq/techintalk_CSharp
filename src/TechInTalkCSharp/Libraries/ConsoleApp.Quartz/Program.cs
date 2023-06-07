using Quartz;
using Quartz.Impl;

namespace ConsoleApp.Quartz
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 1. Create a scheduler Factory
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();

            // 2. Get and start a scheduler
            IScheduler scheduler = await schedulerFactory.GetScheduler();
            await scheduler.Start();

            // 3. Create a job
            IJobDetail job = JobBuilder.Create<NumberGeneratorJob>()
                    .WithIdentity("number generator job", "number generator group")
                    .Build();

            // 4. Create a trigger
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("number generator trigger", "number generator group")
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(15).RepeatForever())
                .Build();

            // 5. Schedule the job using the job and trigger 
            await scheduler.ScheduleJob(job, trigger);

            Console.ReadLine();
        }
    }

    public class NumberGeneratorJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine($"Your # is: {RandomNumber(1000, 9999)}");
            await Task.CompletedTask;
        }

        private int RandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }
    }
}