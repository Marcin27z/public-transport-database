﻿using System;
using System.Collections.Generic;
using TicketRetailSystem.Models.Entity;
using TicketRetailSystem.Models.Enums;

namespace TicketRetailSystem.ViewModels
{
    public class TransactionViewModel
    {
        public int TransactionId { get; set; }
        public decimal TotalPrice  { get; set; }
        public PaymentType PaymentType { get; set; }
        public int TicketId { get; set; }
        public decimal TicketIssuedPrice { get; set; }
        public TicketType TicketType { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
        public DateTime TransactionDate { get; set; }
        public IList<TransactionViewModel> Transcations { get; set; }

    }

    public class TicketTypeViewModel
    {
        public CardType CardType { get; set; }
        public int AmountOfTickets { get; set; }
        public IList<TicketTypeViewModel> TicketZonesWithAmount { get; set; }
    }

    public class CountPeopleViewModel
    {
        public Zone Zone { get; set; }
        public int AmountOfPeople { get; set; }
        public IList<CountPeopleViewModel> TicketTypesWithAmount { get; set; }
    }

    public class DatesViewModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }


    public class ChooseListViewModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Zone? Zone { get; set; }
        public PaymentType? PaymentType { get; set; }
        public DiscountType? DiscountType { get; set; }
    }

    public class ChosenListViewModel
    {
        
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IEnumerable<Zone> Zone { get; set; }
        public IEnumerable<PaymentType> PaymentType { get; set; }
        public IEnumerable<DiscountType> DiscountType { get; set; }

        void func()
        {
            
        }
    }


    public class DateViewModel
    {
        public DateTime CurrentDate { get; set; }
    }

    public class ProfitViewModel
    {
        public decimal Profit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class DetailedInfoViewModel
    {
        public int TransactionId { get; set; }
        public PaymentType PaymentType { get; set; }
        public int TicketId { get; set; }
        public decimal TicketIssuedPrice { get; set; }
        public TicketType TicketType { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
        public DateTime TransactionDate { get; set; }
    }


    public class EverythingViewModel
    {

        public int TotalAmount { get; set; }
        public IList<DetailedInfoViewModel> DetailedInfo { get; set; }
        public ChosenListViewModel ChosenData { get; set; }

    }

}