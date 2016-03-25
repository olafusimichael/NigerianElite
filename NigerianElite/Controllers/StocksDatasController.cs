using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NigerianElite;
using NigerianElite.Models;

namespace NigerianElite.Controllers
{
    public class StocksDatasController : Controller
    {
        private StocksContext db = new StocksContext();

        // GET: StocksDatas
        public ActionResult Index()
        {
            return View(db.StocksDatas.ToList());
        }

        // GET: StocksDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StocksData stocksData = db.StocksDatas.Find(id);
            if (stocksData == null)
            {
                return HttpNotFound();
            }
            return View(stocksData);
        }

        // GET: StocksDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StocksDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Company,Year,Revenues,Cost_of_goods_sold,Gross_Profit,Selling_general___administrative_expenses,Operating_Profit,Interest_Income_net,Earnings_before_Income_taxes,Income_tax_expense,Net_Profit,Cash_and_cash_equivalents,Account_receivable,Inventories,Prepaid_expenses_and_other,Current_Deferred_taxes,Total_Current_Assets,Property_Plant_and_Equipment_net,Intangible_assets,Other_Long_term_Assets,Total_Assets,Bank_lines_of_credit,Trade_accounts_payable,Accrued_Current_liabilities,Total_Current_Liabilities,Long_term_Borrowings,Long_term_Deferred_taxes,Long_term_Commitments,Other_Long_term_Liabilities,Total_Liabilities,Preferred_Stock,Class_A_common_stock,Revaluation_Reserve,Additional_paid_in_capital,Treasury_stock,Retained_earnings,Foreign_currency_translation,Non_controlling_Interest,Total_Liabilities_And_S__E_,Net_Income,C_Increase__Decrease_in_Accounts_receivable,C_Increase__Decrease_in_Inventory,C_Increase__Decrease_in_Prepaid_expenses_and_other,C_Increase__Decrease_in_Deferred_taxes,Increase__Decrease__in_Bank_lines_of_credit,Increase__Decrease__in_Trade_accounts_payable,Increase__Decrease__in_Accrued_liabilities,Cash_Flows_from_Operating_Activities,Increase__Decrease__in_Operating_Cash_Flow,Cash_Flows_from_Investing_Activities,Increase__Decrease__In_Investing_Cash_Flow,Cash_Flows_from_Financing_Activities,Increase__Decrease__in_Financing_Cash_Flow,Net_Cash_Flows,Beginning_Cash_Balance,Forex,Ending_Cash_Balance,Revenue_Growth,Cost_of_goods_sold_as_a___of_Rev_,SG_A_as_a___of_Rev_,Operating_Profit_Margin,ROIC,Cash_Flow_as_a___of_Rev,ROA,ROE,Interest_Incomenet_as_a___of_Rev_,Income_tax_expense_as_a___of_Rev_,Accounts_receivable_as_a___of_Rev_,Inventories_as_a___of_Rev_,Prepaid_expenses_and_other_as_a___of_Rev_,Deferred_taxes_as_a___of_Rev_,Bank_lines_of_credit_as_a___of_Rev_,Trade_accounts_payable_as_a___of_Rev_,Accrued_liabilities_as_a___of_Rev_")] StocksData stocksData)
        {
            if (ModelState.IsValid)
            {
                db.StocksDatas.Add(stocksData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stocksData);
        }

        // GET: StocksDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StocksData stocksData = db.StocksDatas.Find(id);
            if (stocksData == null)
            {
                return HttpNotFound();
            }
            return View(stocksData);
        }

        // POST: StocksDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Company,Year,Revenues,Cost_of_goods_sold,Gross_Profit,Selling_general___administrative_expenses,Operating_Profit,Interest_Income_net,Earnings_before_Income_taxes,Income_tax_expense,Net_Profit,Cash_and_cash_equivalents,Account_receivable,Inventories,Prepaid_expenses_and_other,Current_Deferred_taxes,Total_Current_Assets,Property_Plant_and_Equipment_net,Intangible_assets,Other_Long_term_Assets,Total_Assets,Bank_lines_of_credit,Trade_accounts_payable,Accrued_Current_liabilities,Total_Current_Liabilities,Long_term_Borrowings,Long_term_Deferred_taxes,Long_term_Commitments,Other_Long_term_Liabilities,Total_Liabilities,Preferred_Stock,Class_A_common_stock,Revaluation_Reserve,Additional_paid_in_capital,Treasury_stock,Retained_earnings,Foreign_currency_translation,Non_controlling_Interest,Total_Liabilities_And_S__E_,Net_Income,C_Increase__Decrease_in_Accounts_receivable,C_Increase__Decrease_in_Inventory,C_Increase__Decrease_in_Prepaid_expenses_and_other,C_Increase__Decrease_in_Deferred_taxes,Increase__Decrease__in_Bank_lines_of_credit,Increase__Decrease__in_Trade_accounts_payable,Increase__Decrease__in_Accrued_liabilities,Cash_Flows_from_Operating_Activities,Increase__Decrease__in_Operating_Cash_Flow,Cash_Flows_from_Investing_Activities,Increase__Decrease__In_Investing_Cash_Flow,Cash_Flows_from_Financing_Activities,Increase__Decrease__in_Financing_Cash_Flow,Net_Cash_Flows,Beginning_Cash_Balance,Forex,Ending_Cash_Balance,Revenue_Growth,Cost_of_goods_sold_as_a___of_Rev_,SG_A_as_a___of_Rev_,Operating_Profit_Margin,ROIC,Cash_Flow_as_a___of_Rev,ROA,ROE,Interest_Incomenet_as_a___of_Rev_,Income_tax_expense_as_a___of_Rev_,Accounts_receivable_as_a___of_Rev_,Inventories_as_a___of_Rev_,Prepaid_expenses_and_other_as_a___of_Rev_,Deferred_taxes_as_a___of_Rev_,Bank_lines_of_credit_as_a___of_Rev_,Trade_accounts_payable_as_a___of_Rev_,Accrued_liabilities_as_a___of_Rev_")] StocksData stocksData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stocksData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stocksData);
        }

        // GET: StocksDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StocksData stocksData = db.StocksDatas.Find(id);
            if (stocksData == null)
            {
                return HttpNotFound();
            }
            return View(stocksData);
        }

        // POST: StocksDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StocksData stocksData = db.StocksDatas.Find(id);
            db.StocksDatas.Remove(stocksData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
