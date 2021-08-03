export interface Vaga {
    idVaga?: number;
    descricao: string;
    profissao: string;
    dataCriacao: string;
    local: string;
    idCandidato: number;
    candidatos: Candidato[];
}

export interface Candidato {
    idCandidato?: number;
    nome: string;
    dataNascimento: string;
}