import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  standalone: true,
  templateUrl: './Nav.component.html',
  styleUrl: './Nav.component.scss'
})
export class NavComponent implements OnInit {
  isCollapsed = true;
  constructor() {}

  ngOnInit(): void {
    
  }
}
