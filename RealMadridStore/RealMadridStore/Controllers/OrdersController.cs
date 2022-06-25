﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealMadridStore.Models;
using RealMadridStore.Services;
using RealMadridStore.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RealMadridStore.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IProduct _product;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrder _order;
        private readonly EmailService _email;
        public OrdersController(IProduct product, ShoppingCart shoppingCart, IOrder order, EmailService email)
        {
            _product = product;
            _shoppingCart = shoppingCart;
            _order = order;
            _email = email;
        }
        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);
            var orders = await _order.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            return View(orders);
        }
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartDTO()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
        [AllowAnonymous]
        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _product.GetProduct(id);
            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _product.GetProduct(id);
            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmailAddress = User.FindFirstValue(ClaimTypes.Email);
            await _order.StoreOrderAsync(items, userId, userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();
            string message = "Order Summary : <br/> ";
            foreach (ShoppingCartItem shopping in items)
            {
                message += $"you bought a  {shopping.product.Name}  for a price   {shopping.product.Price} <br/>";
            }
            await _email.SendEmail(message, "22029646@student.ltuc.com", "Order Summary");
            await _email.SendEmail(message, "mutazaltbakhi900@gmail.com", "Order Summary");
            await _email.SendEmail(message, userEmailAddress, "Order Summary");
            return View();
        }
    }
}