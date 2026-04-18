import { Component } from '@angular/core';
import { CurrencyPipe, DatePipe } from '@angular/common';
import { OrderStatusPipe } from '../pipes/order-status-pipe';

@Component({
  selector: 'app-orders',
  imports: [CurrencyPipe, DatePipe, OrderStatusPipe],
  templateUrl: './orders.html',
  styleUrl: './orders.css',
})
export class Orders {
  orders = [
    { id: 1, price: 1200, date: new Date(), status: 1 },
    { id: 2, price: 800,  date: new Date(), status: 2 },
    { id: 3, price: 1500, date: new Date(), status: 3 },
  ];
}
