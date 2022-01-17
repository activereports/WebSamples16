import * as React from 'react';

interface ReportProviderInterface{
    currentReport: string;
    setCurrentReport: (id: string)=>void;
    reportsList: string[];
}

export const reportContext = React.createContext<ReportProviderInterface | undefined>(undefined);

export const ReportProvider: React.FC = ({children})=>{
    const [currentReport, setCurrentReport] =  React.useState('');
    const [reportsList, setReportsList] = React.useState([]);
    React.useEffect(() => {
        const fetchReportsList = async () => {
          try {
            const fetchResult = await fetch(
              "reportslist"
            ).then((response) => response.json());
            setReportsList(fetchResult);
            setCurrentReport(fetchResult[0]);
          } catch (err) {
            console.log("error of fetching the report list", err);
          }
        };
        fetchReportsList();
      // eslint-disable-next-line react-hooks/exhaustive-deps
      }, []);    
    const api: ReportProviderInterface = {
        currentReport : currentReport,
        setCurrentReport(id: string){
            setCurrentReport(id);
        },
        reportsList : reportsList
    }
    return <reportContext.Provider value={api}>
        {children}
    </reportContext.Provider>
}