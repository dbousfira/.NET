using System;

[Table("APP_COMMANDE")]
public class Order
{
	public Order()
	{
        [Key]
        public int MyProperty { get; set; }
    }
}
