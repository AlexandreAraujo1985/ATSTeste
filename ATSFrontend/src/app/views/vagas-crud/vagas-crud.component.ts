import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-vagas-crud',
  templateUrl: './vagas-crud.component.html',
  styleUrls: ['./vagas-crud.component.css']
})
export class VagasCrudComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  navigateToCriarVaga(): void {
    this.router.navigate(['/vagas/criar']);
  }

}
