export class Verb
{
 Translation: string;
 Infinitive: string;
 ConjugationTense: string;
 ConjugationIch: string;
 ConjugationDu: string;
 ConjugationEr: string;
 ConjugationWir: string;
 ConjugationIhr: string;
 Conjugationsie: string;
 ConjugationSie: string;
 PhotoPath: string;
 Description: string;

 constructor(translation: string, infinitive: string, conjugationTense: string, conjugationIch: string,
             conjugationDu: string, conjugationEr: string, conjugationWir: string, conjugationIhr: string,
             conjugationsie: string, conjugationSie: string)
 {
    this.Translation = translation;
    this.Infinitive = infinitive;
    this.ConjugationTense = conjugationTense;
    this.ConjugationIch = conjugationIch;
    this.ConjugationDu = conjugationDu;
    this.ConjugationEr = conjugationEr;
    this.ConjugationWir = conjugationWir;
    this.ConjugationIhr = conjugationIhr;
    this.Conjugationsie = conjugationsie;
    this.ConjugationSie = conjugationSie;
 }
}
