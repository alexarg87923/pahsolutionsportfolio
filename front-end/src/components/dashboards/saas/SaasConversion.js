import React from 'react';
import { Card, Col, Row } from 'react-bootstrap';
import SubtleBadge from 'components/common/SubtleBadge';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import CountUp from 'react-countup';

const SaasConversion = () => {
  return (
    <Card className="h-100">
      <Card.Body>
        <Row className="flex-between-center">
          <Col className="d-md-flex d-lg-block flex-between-center">
            <h6 className="mb-md-0 mb-lg-2">Conversion</h6>
            <SubtleBadge bg="primary" pill>
              <FontAwesomeIcon icon="caret-up" /> 29.4%
            </SubtleBadge>
          </Col>
          <Col xs="auto">
            <h4 className="fs-6 fw-normal text-primary">
              <CountUp
                start={0}
                end={28.5}
                suffix="%"
                duration={2.75}
                decimals={2}
                decimal="."
              />
            </h4>
          </Col>
        </Row>
      </Card.Body>
    </Card>
  );
};

export default SaasConversion;
