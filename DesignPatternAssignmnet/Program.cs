using DesignPatternAssignmnet;

internal class Program
{
    private static void Main(string[] args)
    {
        // Get input from the user for the amount
        Console.Write("Enter the amount $: ");
        double amount;
        while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please enter a valid positive number.");
            Console.Write("Enter the amount: ");
        }

        int cardType = 3;
        do
        {
        // Get input from the user for the card type
        Console.WriteLine("Enter the card number type (1: Membership, 2: Employee, or 3: NoCard): ");
        }
        while (!int.TryParse(Console.ReadLine(),out cardType));
        
        IDiscount discount = null;

        // Apply discount based on the card type
        switch (cardType)
        {
            case 1:
                discount = new MembershipCardDiscount();
                break;
            case 2:
                discount = new EmployeeCardDiscount();
                break;
            case 3:
                discount = new NoCardDiscount();
                break;
            default:
                Console.WriteLine("Invalid card type. No discount applied.");
                break;
        }
        if (discount != null)
        {
        // used Strategy Pattern to Achieve this Functionality
        DiscountDecider discountDecider = new DiscountDecider(discount);
        amount = discountDecider.Checkout(amount);
        Console.WriteLine($"Pay ${amount}");
        }
        else { 
        Console.WriteLine("Try Again");
        }
    }
}