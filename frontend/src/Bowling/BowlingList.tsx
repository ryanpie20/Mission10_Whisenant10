import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlingList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchbowlerData = async () => {
      const rsp = await fetch('http://localhost:5269/api/BowlingLeague');
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchbowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4>Here are the Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
            <th>Team Name</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((f) => (
            <tr key={f.bowlerId}>
              <td>
                <td>{`${f.bowlerFirstName} ${f.bowlerMiddleInit ? f.bowlerMiddleInit + '. ' : ''}${f.bowlerLastName}`}</td>
              </td>
              <td>{f.bowlerAddress}</td>
              <td>{f.bowlerCity}</td>
              <td>{f.bowlerState}</td>
              <td>{f.bowlerZip}</td>
              <td>{f.bowlerPhoneNumber}</td>
              <td>{f.teamName}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlingList;
