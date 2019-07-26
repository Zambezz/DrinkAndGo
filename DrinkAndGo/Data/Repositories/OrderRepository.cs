using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DrinkAndGo.Data.Repositories
{
	public class OrderRepository : IdentityDbContext<IdentityUser>, IOrderRepository
	{
		private readonly AppDbContext _appDbContext;
		private readonly ShoppingCart _shoppingCart;

		public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
		{
			_appDbContext = appDbContext;
			_shoppingCart = shoppingCart;
		}

		public void CreateOrder(Order order)
		{
			order.OrderPlaced = DateTime.Now;
			_appDbContext.Orders.Add(order);
			var shoppingCartItems = _shoppingCart.ShoppingCartItems;
			foreach (var shoppingCartItem in shoppingCartItems)
			{
				var orderDetail = new OrderDetail()
				{
					Amount = shoppingCartItem.Amount,
					DrinkId = shoppingCartItem.Drink.DrinkId,
					OrderId = order.OrderId,
					Price = shoppingCartItem.Drink.Price
				};
				_appDbContext.OrderDetails.Add(orderDetail);
			}
			_appDbContext.SaveChanges();
		}
	}
}
