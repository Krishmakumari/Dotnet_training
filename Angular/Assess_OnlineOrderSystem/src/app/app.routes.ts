import { Routes } from '@angular/router';
import { Home } from './home/home';
import { Orders } from './orders/orders';

export const routes: Routes = [
  { path: '', component: Home },
  { path: 'orders', component: Orders }
];