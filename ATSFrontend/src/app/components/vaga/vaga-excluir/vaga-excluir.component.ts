import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Vaga } from '../vaga.model';
import { VagaService } from '../vaga.service';

@Component({
  selector: 'app-vaga-excluir',
  templateUrl: './vaga-excluir.component.html',
  styleUrls: ['./vaga-excluir.component.css']
})
export class VagaExcluirComponent implements OnInit {
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

  constructor(private vagaService: VagaService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    const idVaga = this.route.snapshot.paramMap.get("idVaga");
    this.vagaService.detalhar(idVaga).subscribe((vaga) => {
      this.vaga = vaga;
      this.vaga.dataCriacao = this.vaga.dataCriacao.substring(0, 10)
    });
  }

  excluirVaga(): void {
    this.vagaService.excluir(this.vaga.idVaga).subscribe(() => {
      this.vagaService.showMessage('Vaga Encerrda!');
      this.router.navigate(['vagas/']);
    });
  }

  cancelar(): void {
    this.router.navigate(['vagas/']);
  }

}
