using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.DTO;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CashIncomeController : Controller
    {
        readonly ICashIncomeService _service;        
        private readonly IPostgreSQLRepository<IncomeItem> _incomeItemRepository;

        public CashIncomeController(ICashIncomeService service, IPostgreSQLRepository<IncomeItem> incomeItemRepository)
        {
            _service = service;
            _incomeItemRepository = incomeItemRepository;
        }

        [HttpGet("AllItems")]
        public IEnumerable<CashIncome> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public CashIncome Get(Guid id)
        {
            return _service.GetById(id);
        }
        /*
        [HttpPost("Create")]/*
        public IActionResult Post([FromBody] CashIncomeCreateDto dto)
        {
            // Найти или создать IncomeItem
            //var incomeItem = _incomeItemRepository.GetAll()
            //    .FirstOrDefault(i => i.Name == dto.IncomeItemName);
            /*
            if (incomeItem == null)
            {
                incomeItem = new IncomeItem { Name = dto.IncomeItemName };
                _incomeItemRepository.Create(incomeItem);
            }

            // Создать новую запись CashIncome и связать с IncomeItem
            var cashIncome = new CashIncome
            {
                TransactionDate = dto.TransactionDate,
                Amount = dto.Amount,
                Description = dto.Description,
                FromWhom = dto.FromWhom,
                IncomeItemId = incomeItem.Id,
                IncomeItem = incomeItem
            };

            var result = _service.Create(cashIncome);
            return Ok(result);*/
        }
        
        
    
}
