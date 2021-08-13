import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-candidato-crud',
  templateUrl: './candidato-crud.component.html',
  styleUrls: ['./candidato-crud.component.css']
})
export class CandidatoCrudComponent implements OnInit {
  showSpinner = false;
  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  navigateToCriarCantidato(): void {
    this.router.navigate(['/candidatos/criar']);
  }
}
