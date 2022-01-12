import { Component, OnInit } from '@angular/core';
import { IPersonPhone } from '../models/person-phone.model';
import { PersonPhoneService } from './person-phone.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pesrson-phone',
  templateUrl: './person-phone.component.html',
  styleUrls: ['./person-phone.component.css']
})
export class PersonPhoneComponent implements OnInit {

  personPhones: IPersonPhone[];
  public displayedColumns: string[] = ['phoneNumberTypeID', 'phoneNumber', 'phoneNumberTypeID']
  isWaiting: Boolean = false;

  constructor(private service: PersonPhoneService, private router: Router) { }

  ngOnInit() {
    this.isWaiting = true;
    this.service.getPersonPhones().subscribe(customers => {
      this.personPhones = customers;
      this.isWaiting = false;
    })
  }

  addNew() {
    this.router.navigate(['person-phone']);
  }

}
