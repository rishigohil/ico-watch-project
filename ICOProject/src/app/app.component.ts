import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

class TokenInfo {
  isScam: boolean;
  errorMessage: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    constructor(private _httpService: Http) { }

    apiValues: string[] = [];
    tokenName: string;
    tokenResult = new TokenInfo();

    ngOnInit() {
        this._httpService.get('/api/values/icos').subscribe(values => {
            this.apiValues = values.json() as string[];
        });
    }

    CheckToken(event) {
      var icoName = this.tokenName;
      console.log(icoName);

      this._httpService.get('/api/values/icos/' + icoName).subscribe(values => {
        this.tokenResult = values.json() as TokenInfo;
        console.log(this.tokenResult.isScam);
        console.log(this.tokenResult.errorMessage);
      });

      if (this.tokenResult) {
        if (this.tokenResult.errorMessage != null) {
          alert(this.tokenResult.errorMessage);
        } else {
          var tokenMessage = "Token " + "'" +icoName +"'";
          var scamMessage = (this.tokenResult.isScam) ? (tokenMessage + " is a scam!") : (tokenMessage + " is not a scam.");
          alert(scamMessage);
        }
      }

    }

}
