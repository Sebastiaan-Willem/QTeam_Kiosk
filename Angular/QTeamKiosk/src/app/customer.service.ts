import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {Customer} from './Customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  private customerUrl = 'https://localhost:44340/api/Customer';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http:HttpClient) { }

  addCustomer(customer: Customer): Observable<Customer> {

    return this.http.post<Customer>(this.customerUrl, customer, this.httpOptions);

  }
}

