﻿using Microsoft.AspNetCore.Mvc;
using Project2.Models;
using Project2.Services;

namespace Project2
{
    public interface IProductRepository
    {
        Task<bool> ProductExist(int productId);
        Task<Product?> GetProductById(int productId);
        Task<(IEnumerable<Product>?, PaginationMetadata)> GetAllProductsAsync(string? name,int pageNumber, int pageSize);
        Task AddProduct(string filePath, Product product);
    }
}
