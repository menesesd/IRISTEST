import { Component, OnInit, ViewChild } from '@angular/core';
import {MatAccordion} from '@angular/material/expansion';

@Component({
  selector: 'app-to-do-list',
  templateUrl: './to-do-list.component.html',
  styleUrls: ['./to-do-list.component.scss']
})
export class ToDoListComponent implements OnInit {
  @ViewChild(MatAccordion) accordion!: MatAccordion;
  
  functions = [{name:"All", icon:null}, {name:"Otra opción 1", icon:'add'}, {name:"Otro opción 2", icon:'delete'}]
  constructor() { }

  ngOnInit(): void {
  }

}
