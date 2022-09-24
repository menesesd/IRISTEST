import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-all-check',
  templateUrl: './all-check.component.html',
  styleUrls: ['./all-check.component.scss']
})
export class AllCheckComponent implements OnInit {
  functions = ["Opción 1","Opción 2","Opción 3","Opción 4","Opción 5","Opción 6"]
  constructor() { }

  ngOnInit(): void {
  }

}
