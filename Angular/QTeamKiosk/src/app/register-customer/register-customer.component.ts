import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { CustomerService } from '../customer.service';
import { faCogs } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-register-customer',
  templateUrl: './register-customer.component.html',
  styleUrls: ['./register-customer.component.css']
})
export class RegisterCustomerComponent implements OnInit {
  faCoffee = faCogs;

  registerUser: FormGroup = new FormGroup({
    gender: new FormControl('Male', Validators.required),
    firstName: new FormControl('', Validators.required),
    name: new FormControl('', Validators.required),
    licencePlate: new FormControl('', Validators.required),
    email: new FormControl('', [Validators.required, Validators.email]),
    street: new FormControl('', Validators.required),
    houseNumber: new FormControl('', Validators.required),
    unit: new FormControl(''),
    city: new FormControl('', Validators.required),
    postalCode: new FormControl('', Validators.required),
    phoneNumber: new FormControl('', Validators.required), 
    subscribedToUpdates: new FormControl(''),  
    
    // password: new FormControl('', [Validators.required, Validators.minLength(8), Validators.maxLength(16)]),
  });
  validationErrors: string[] = [];
  constructor(private customerService: CustomerService) { }

  ngOnInit(): void {
  }

  register() {
    this.customerService.addCustomer(this.registerUser.value).subscribe(
      response => {

      },error => {
        console.error(error);
        this.validationErrors.push(error);
      });
  }

}
