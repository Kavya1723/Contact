import { Component, OnInit } from '@angular/core';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { CommonModule } from '@angular/common';
import { ContactFormComponent } from './components/contact-form/contact-form.component';
import { ContactListComponent } from './components/contact-list/contact-list.component';
import { ContactPopupComponent } from './components/contact-popup/contact-popup.component';
import { ContactService } from './services/contact.service';
import { Contact } from './models/contact.model';
//import { RouterOutlet } from '@angular/router';



// interface Contact {
// firstName: string;
// lastName: string;
// email: string;
// phoneNumber: string;
// address: string;
// city: string;
// state: string;
// country: string;
// postalCode: string;
// }
@Component({
selector: 'app-root',
standalone:true,
imports: [CommonModule],
templateUrl: './app.component.html',
styleUrls: ['./app.component.css'] // optional if you want styles
})
export class AppComponent{} 
// implements OnInit 
// {
// contacts: Contact[] = [];
// sortColumn: keyof Contact = 'firstName';
// sortAscending: boolean = true;

// constructor(private contactService: ContactService) {}

// ngOnInit(): void {
// this.loadContacts();
// }
// loadContacts() {
// this.contactService.getContacts().subscribe({
// next: data => (this.contacts = data),
// error: err => console.error('Error loading contacts:', err)
// });
// }

// sortBy(column: keyof Contact) {
// if (this.sortColumn === column) {
// this.sortAscending = !this.sortAscending;
// } else {
// this.sortColumn = column;
// this.sortAscending = true;
// }
// this.contacts.sort((a, b) => {
//   const aVal = a[column];
//   const bVal = b[column];
//   if (aVal === bVal) return 0;
//   if (aVal === null || aVal === undefined) return this.sortAscending ? -1 : 1;
//   if (bVal === null || bVal === undefined) return this.sortAscending ? 1 : -1;
//   return this.sortAscending
//     ? aVal.toString().localeCompare(bVal.toString())
//     : bVal.toString().localeCompare(aVal.toString());
// });
// }
// }
