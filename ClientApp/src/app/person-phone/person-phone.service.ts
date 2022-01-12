import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IPersonPhone } from '../models/person-phone.model';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class PersonPhoneService {

  constructor(private httpClient: HttpClient) { }

  getPersonPhones(): Observable<IPersonPhone[]> { 
    let url = `/api/personphone`;
    return this.httpClient.get<IPersonPhone[]>(url);
  }

  getPersonPhone(id: number): Observable<IPersonPhone> {
    let url = `/api/personphone/` + id;
    return this.httpClient.get<IPersonPhone>(url);
  }

  updatePersonPhone(id: number, personPhone: IPersonPhone): Observable<IPersonPhone> {
    let url = `/api/personphone/` + id;
    return this.httpClient.put<IPersonPhone>(url, personPhone, httpOptions);
  }

  createPersonPhone(personPhone: IPersonPhone): Observable<IPersonPhone> {
    let url = `/api/personphone`;
    return this.httpClient.post<IPersonPhone>(url, personPhone, httpOptions);
  }
}
