import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  private apiUrl = 'https://localhost:5001/api/contacts';

  constructor(private http: HttpClient) { }

  getContacts() {
    return this.http.get(this.apiUrl);
  }

  addContact(contact: any) {
    return this.http.post(this.apiUrl, contact);
  }
}