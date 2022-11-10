using GL.WebApi.DTO.Interfaces;

namespace GL.WebApi.Services
{
    public class SimpleCalculatorService : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public int Subtract(int start, int amount)
        {
            if ((start < 0 && amount >= 0) || (start < 0 && amount < 0 & start >= amount))
                return start + (amount);

            return start - (amount);
        }
    }
}
