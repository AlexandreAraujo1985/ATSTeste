import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Vaga } from '../vaga.model';
import { VagaService } from '../vaga.service';

@Component({
  selector: 'app-vaga-criar',
  templateUrl: './vaga-criar.component.html',
  styleUrls: ['./vaga-criar.component.css']
})
export class VagaCriarComponent implements OnInit {
  vaga: Vaga = {
    idVaga: 0,
    descricao: '',
    profissao: '',
    dataCriacao: '',
    local: '',
    idCandidato: 0,
    candidatos: [{
      idCandidato: 0,
      nome: '',
      dataNascimento: ''
    }]
  }

  constructor(private vagaService: VagaService, private router: Router) { }

  ngOnInit(): void {
  }

  criarVaga(): void {
    this.vaga.candidatos = [];
    this.vagaService.criar(this.vaga).subscribe(() => {
      this.vagaService.showMessage('Vaga Cadastrada!');
      this.router.navigate(['vagas/']);
    });
  }

  cancelar(): void {
    this.router.navigate(['vagas/']);
  }

}
