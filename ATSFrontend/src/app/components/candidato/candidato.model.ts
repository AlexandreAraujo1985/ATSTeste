export interface Candidato {
    idCandidato?: number;
    idVaga?: number;
    ativo: boolean;
    nome: string;
    profissao: string;
    dataNascimento: string;
    curriculo: Curriculo;
}

export interface Curriculo {
    idCurriculo: number;
    idCandidato: number;
    idExperiencia: number;
    formacaoAcademica: string;
    experiencias: Experiencia[];
}

export interface Experiencia {
    idExperiencia: number;
    nomeEmpresa: string;
    dataInicio: string;
    dataFim: string;
}