namespace FindBetweenTwoNumbers
{
    public class NumberFinder
    {
        private readonly int SECRET_NUMBER;

        public NumberFinder(int secretNumber)
        {
            SECRET_NUMBER = secretNumber;
        }

        private bool IsNumberHigherThanSecret(int number)
        {
            return number > SECRET_NUMBER;
        }

        public int FindSecretNumber(int min, int max)
        {
            int middle = min + ((max - min) / 2);

            if (IsNumberHigherThanSecret(middle) && !IsNumberHigherThanSecret(middle - 1))
                return middle - 1;

            if (!IsNumberHigherThanSecret(middle))
                return FindSecretNumber(middle, max);

            return FindSecretNumber(min, middle);
        }
    }
}