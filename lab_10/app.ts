import { Component } from '@angular/core';
import { Home } from './home/home';
import { About } from './about/about';
import { Contact } from './contact/contact';

@Component({
  selector: 'app-root',
  imports: [Home, About, Contact],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  title = 'my-app';
}